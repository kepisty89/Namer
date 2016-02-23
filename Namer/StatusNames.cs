namespace Namer
{
    using System.ComponentModel;

    /// <summary>
    /// Status names.
    /// </summary>
    public enum StatusNames
    {
        /// <summary>
        /// Ready status.
        /// </summary>
        [Description("Ready.")]
        Ready,

        /// <summary>
        /// The ok.
        /// </summary>
        [Description("OK.")]
        OK,

        /// <summary>
        /// The renaming.
        /// </summary>
        [Description("Renaming...")]
        Renaming
    }
}
