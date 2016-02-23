namespace Namer
{
    using System.ComponentModel;

    /// <summary>
    /// Status names.
    /// </summary>
    public enum ApplicationStatus
    {
        /// <summary>
        /// Ready status.
        /// </summary>
        [Description("Ready.")]
        Ready,

        /// <summary>
        /// The renaming.
        /// </summary>
        [Description("Renaming...")]
        Renaming,

        /// <summary>
        /// The delete.
        /// </summary>
        [Description("Deleting...")]
        Delete
    }
}
