namespace Lib.DirectPIN.ConstantValues
{
    /// <summary>typeTransaction — seção 6.1 / 7.</summary>
    public enum TipoTransacao
    {
        DEBIT,
        CREDIT,
        VOUCHER,
        PIX,
        CREDIARIO
    }

    /// <summary>creditType — seção 6.1 / 7.</summary>
    public enum TipoCredito
    {
        INSTALLMENT,
        NO_INSTALLMENT
    }

    /// <summary>interestType — seção 6.1 / 7.</summary>
    public enum TipoJuros
    {
        MERCHANT,
        CLIENT,
        ISSUER
    }

    /// <summary>inputType (collect) — seção 6.6 / 7.</summary>
    public enum TipoEntrada
    {
        NUMERIC,
        NUMERIC_PASSWORD,
        PASSWORD,
        EMAIL,
        TEXT
    }

    /// <summary>typeMessage (message) — seção 6.7.</summary>
    public enum TipoMensagem
    {
        TEXT,
        QR_CODE
    }

    /// <summary>surveyType (survey) — seção 6.8.</summary>
    public enum TipoPesquisa
    {
        NPS,
        CSAT,
        CES,
        GENERIC
    }

    /// <summary>
    /// codeResult — seção 8.4. Referência/lookup apenas: os DTOs de resposta expõem
    /// CodeResult como int (podem existir códigos adicionais conforme o adquirente/terminal —
    /// seção 8.4 pede tolerância a valores desconhecidos).
    /// </summary>
    public enum CodigoResultado
    {
        OK = 0,
        ALREADY_OPEN = 1,
        INVALID_CALL = 2,
        INVALID_PARAMETER = 3,
        TIMEOUT = 4,
        CANCELED_OPERATION = 5,
        UNINITIALIZED_PINPAD = 6,
        INVALID_MODEL = 7,
        UNSUPPORTED_OPERATION = 8,
        EXPIRED_TABLES = 9,
        TABLE_WRITE_ERROR = 10,
        MAG_CARD_READ_ERROR = 11,
        MISSING_PIN_KEY = 12,
        MISSING_CARD = 13,
        BUSY_PINPAD = 14,
        SAM_MODULE_ERROR = 15,
        MISSING_SAM = 16,
        INVALID_SAM = 17,
        MUTE_CARD = 18,
        CARD_COMMUNICATION_ERROR = 19,
        INVALIDATED_CARD = 20,
        PROBLEMATIC_CARD = 21,
        CARD_WITH_INVALID_DATA = 22,
        CARD_WITHOUT_APPLICATION = 23,
        UNUSED_APPLICATION = 24,
        FALLBACK_ERROR = 25,
        INVALID_VALUE = 26,
        EXCEEDS_AID_CAPACITY = 27,
        BLOCKED_CARD = 28,
        MULTIPLE_CTLSS = 29,
        CTLSS_COMMUNICATION_ERROR = 30,
        INVALIDATED_CTLSS = 31,
        PROBLEMATIC_CTLSS = 32,
        CTLSS_WITHOUT_APPLICATION = 33,
        UNSUPPORTED_CTLSS_APPLICATION = 34,
        EXTERNAL_CTLSS_DEVICE = 35,
        CTLSS_CHANGE_INTERFACE = 36,
        INTERNAL_ERROR = 37,
        ABORTED_OPERATION = 38,
        CARD_CHIP = 39,
        PRODUCT_EMPTY = 40,
        DIVERT_CARD_NUMBER = 41,
        REJECTED_TRANSACTION = 42,
        CARD_REJECTED = 43,
        INVALID_TRANSACTION = 44,
        PRINT_ERROR = 45,
        EMPTY_TRANSACTION = 46,
        CARD_NUMBER_INVALID = 47,
        INVALID_EXP_DATE = 48,
        NONE_PRODUCTS = 49,
        NO_CREDIT_INSTALLMENT_SELECTED = 50,
        LOGON_NOT_PERFORMED = 51,
        RESET_CONFIGURATION = 52,
        MIN_INSTALLMENT_AMOUNT = 53,
        MAX_INSTALLMENT_AMOUNT = 54,
        MAX_INSTALLMENT = 55
    }

    /// <summary>
    /// finalResult — seção 8.1. Referência/lookup apenas (RespostaTransacao.FinalResult é
    /// string): podem existir outros valores conforme o adquirente — seção 8.1 pede tolerância.
    /// </summary>
    public enum ResultadoFinal
    {
        APPROVED,
        PENDING,
        CONFIRMED,
        UNDONE,
        REPROVED_HOST,
        REPROVED_CARD,
        CANCELED,
        ABORTED,
        CONNECTION_ERROR,
        CARD_READ_ERROR
    }

    /// <summary>
    /// typeCard — seção 6.1 / 7. Referência/lookup apenas (campo de resposta é string).
    /// </summary>
    public enum TipoCartao
    {
        MAGNETIC,
        EMV_CONTACT,
        CONTACTLESS_STRIPE,
        CONTACTLESS_EMV,
        TYPED,
        NONE
    }

    /// <summary>
    /// status (consultas transactionStatus/listTransactions) — seção 8.7. Referência/lookup
    /// apenas (campo de resposta é string).
    /// </summary>
    public enum StatusTransacao
    {
        FAILED,
        PENDING_CONFIRMATION,
        AUTHORIZED,
        CONFIRMED,
        CANCELED,
        UNDONE
    }
}
