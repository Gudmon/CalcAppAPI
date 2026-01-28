namespace CalcAppAPI.Models.Email
{
    public class EmailSendException : Exception
    {
        public string Header { get; }
        public string BlobName { get; }

        public EmailSendException(
            string header,
            string message,
            string blobName,
            Exception inner)
            : base(message, inner)
        {
            Header = header;
            BlobName = blobName;
        }
    }
}
