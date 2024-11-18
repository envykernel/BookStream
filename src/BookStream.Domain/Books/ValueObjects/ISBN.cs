namespace BookStream.Domain.Books.ValueObjects
{
    /// <summary>
    /// ISBN value object
    /// </summary>
    public sealed record ISBN 
    {
        public string Value { get; }

        public override string ToString()
        {
            return Value;
        }

        public ISBN(string value)
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ISBN cannot be empty");
            }

            if(!IsValidISBN(value))
            {
                throw new ArgumentException("ISBN is not valid");
            }

            Value = value;
        }

        private static bool IsValidISBN(string isbn)
        {
            return isbn.Length == 10 || isbn.Length == 13;
        }

    }
}