# ACBr DirectPIN Demo

Exemplo **WinForms** (.NET 4.8, **x86**) para integração **DirectPIN** (Transire), pelo Projeto ACBr. Utilizando a integração **Serial** — JSON + Base64 + CRC16 sobre porta serial. Inclui PDV de exemplo, impressão utilizando o **ACBrLib.PosPrinter**.

---

## Início rápido

Crie `ACBr.DirectPIN.Demo\App.config` conforme o [exemplo abaixo](#configuração).

Abra `ACBr.DirectPIN.sln`, restaure os pacotes NuGet (se necessário) e compile em **Debug**. Em seguida:

1. Copie `ACBrPosPrinter32.dll` para `ACBr.DirectPIN.Demo\bin\Debug\ACBrLib\x86\`.
2. Na tela de **Configuração**, informe a porta serial (COMx) do pinpad DirectPIN.
3. Inicie o `.exe` e aguarde **Porta COMx conectada** no log.

---

## Requisitos

- Windows 10+, **.NET Framework 4.8** (Lib.FormsAuxiliares e ACBr.DirectPIN.Demo), Visual Studio 2022 ou Build Tools
- `Lib.Utils` e `Lib.DirectPIN` multi-target: **net48 / netstandard2.0 / net6.0**
- Aplicação Demo configurada para **32 bits**
- Pinpad DirectPIN conectado na porta USB
- DLL nativa ACBrLib PosPrinter (impressão de comprovantes)

---

## DLLs (copiar manualmente)

| Origem | Destino |
|--------|---------|
| `ACBrPosPrinter32.dll` (Projeto ACBr) | `bin\Debug\ACBrLib\x86\` |

NuGet (`ACBrLib.Core`, `ACBrLib.PosPrinter`) gera só assemblies gerenciados — versões no `.csproj`.

---

## Solução

| Projeto | Função |
|---------|--------|
| `ACBr.DirectPIN.Demo` | PDV Exemplo (`FrmPdv`, `FrmConfiguracao`) |
| `Lib.DirectPIN` | Protocolo Serial DirectPIN (frame SYN/Base64/CRC16/ETB), cliente e transporte |
| `Lib.FormsAuxiliares` | Diálogos auxiliares (seleção, coleta numérica, confirmação de valor) |
| `Lib.Utils` | Helpers, enums, log |

---

## Uso

1. Informe o valor da operação e use **Efetuar Pagamento** (assistente Tipo → Modalidade → Parcelas) ou os atalhos (**Débito**, **Crédito à Vista**, **Crédito Parcelado pelo Estabelecimento**, **Crédito Parcelado pelo Emissor** e **PIX**); pagamentos parciais/múltiplos são suportados.
2. Preview do comprovante e grid de pagamentos da venda; **Nova venda** limpa a tela.
3. **Administrativo:** Cancelar/Confirmar/Desfazer por NSU, Abortar operação. O comprovante (`receiptContent`) só é retornado pelas operações `transaction` (mesmo com status `PENDING`) e `cancelTransaction` — `confirmTransaction`/`undoTransaction` nunca retornam comprovante, por isso não há impressão nessas duas.
4. **Consultar Transações:** consulta por status (CustomerId) ou listagem com filtros (NSU, status, tipo, período).
5. **Utilitários:** Coletar dados, Exibir mensagem, Pesquisa de satisfação.
6. **Configuração:** porta serial (baud/paridade/stop bits) do DirectPIN, impressora ESC/POS, envio automático de comprovante.

**Deploy:** copie a pasta `bin\Debug` ou `Release` inteira (exe, `Lib.*.dll` e `ACBrLib\x86\`).

---

## Configuração

Crie `ACBr.DirectPIN.Demo\App.config` com o conteúdo abaixo:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
  </startup>
  <appSettings>
    <add key="DirectPIN_PortaCom" value="" />
    <add key="DirectPIN_BaudRate" value="19200" />
    <add key="DirectPIN_DataBits" value="8" />
    <add key="DirectPIN_Parity" value="None" />
    <add key="DirectPIN_StopBits" value="One" />
    <add key="DirectPIN_EntityIdentifier" value="" />
    <add key="DirectPIN_TimeoutAckNak" value="5000" />
    <add key="DirectPIN_TimeoutOperacao" value="120000" />
    <add key="DirectPIN_ConfirmarAutomaticamente" value="true" />
    <add key="PosPrinter_Porta" value="" />
    <add key="PosPrinter_Modelo" value="ppEscPosEpson" />
    <add key="PosPrinter_CortarPapel" value="true" />
    <add key="PosPrinter_Colunas" value="48" />
    <add key="PosPrinter_Espacos" value="0" />
    <add key="PosPrinter_Buffer" value="0" />
    <add key="PosPrinter_LinhasPular" value="0" />
    <add key="PosPrinter_TraduzirTags" value="true" />
    <add key="PosPrinter_IgnorarTags" value="false" />
    <add key="PosPrinter_ControlePorta" value="false" />
    <add key="PosPrinter_ArqLog" value="" />
    <add key="PosPrinter_PaginaCodigo" value="None" />
    <add key="PosPrinter_ImprimirAutomaticamente" value="false" />
  </appSettings>
</configuration>
```

| Chave | Uso |
|-------|-----|
| `DirectPIN_PortaCom`, `BaudRate`, `DataBits`, `Parity`, `StopBits` | Parâmetros da porta serial do pinpad (deixe `PortaCom` vazio e configure manualmente) |
| `DirectPIN_EntityIdentifier` | Identificador da entidade/rota fixado no primeiro uso |
| `DirectPIN_TimeoutAckNak`, `TimeoutOperacao` | Timeouts do protocolo (ms) |
| `DirectPIN_ConfirmarAutomaticamente` | `true` = `autoConfirm` automático nas transações |
| `PosPrinter_*` | Porta, modelo, colunas, corte de papel e impressão automática do comprovante |
| `PosPrinter_ImprimirAutomaticamente` | `true` imprime cada comprovante de transação/cancelamento automaticamente; `false` só preview |

Ajuste os valores conforme seu pinpad/impressora. Na tela de configuração, opções da impressora também são gravadas em `ACBrLib.ini`.

---

## Desenvolvimento

- **x86** — `PlatformTarget=x86`, `Prefer32Bit=true` (projeto Demo)
- **Protocolo Serial:** frame `SYN(0x16) + Base64(JSON) + CRC16hi + CRC16lo + ETB(0x17)`, CRC-16/CCITT sobre os bytes Base64, ACK/NAK com retry
- **ACBrLibPosPrinter** — uma instância (`PosPrinterConfigService`); chamadas via `AcbrNativeThread.Executar` na thread da UI; corte de papel via tag `</corte_total>` embutida no texto (não é uma chamada direta de API)
- Comprovante impresso por transação e por cancelamento (mesmo `PENDING`); confirmação/desfazimento não geram comprovante
- Serviços principais: `DirectPINDemoService`, `DemoPosPrinterService`
- Constantes do protocolo: `Lib.DirectPIN\ConstantValues\`

---

## Problemas comuns

| Sintoma | O que checar |
|---------|----------------|
| `App.config` inválido ou não encontrado | Crie `ACBr.DirectPIN.Demo\App.config` com o XML da seção [Configuração](#configuração) |
| Aviso 32 bits | Build x86, não Any CPU 64 |
| Porta serial não conecta | COM correta, baud/paridade/stop bits, cabo/driver USB-serial |
| Erro impressora | `ACBrLib\x86\ACBrPosPrinter32.dll` presente em `bin\Debug\` |
| Sem corte de papel | `PosPrinter_Modelo` compatível com ESC/POS (não `ppTexto`), `PosPrinter_CortarPapel=true` |
| Sem impressão automática | `PosPrinter_ImprimirAutomaticamente=1` |

Logs: pasta `Logs\` e painel no PDV.

---

## Referências

| Recurso | Link |
|---------|------|
| Projeto ACBr | https://www.projetoacbr.com.br/ |
| NuGet PosPrinter | https://www.nuget.org/packages/ACBrLib.PosPrinter |
| Documentação DirectPIN | Fornecida pela Transire através do Portal do Desenvolvedor - https://desenvolvedor.transire.com.br/ |

---

## Suporte

Em caso de dúvidas, entre em contato pelos canais abaixo:

- [Fórum do Projeto ACBr — TEF](https://www.projetoacbr.com.br/forum/)
- [Discord do Projeto ACBr](https://discord.com/channels/798697718800318484/1529565750967140623)
- [Suporte via tickets](https://suporte.projetoacbr.com.br/)
