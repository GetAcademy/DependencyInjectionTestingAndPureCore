namespace InventoryFP
{
    namespace IntroErrorHandling
    {
        public class Result<T>
        {
            public bool IsSuccess { get; }
            public T? Value { get; }
            public string? ErrorMessage { get; }

            private Result(T value) // success
            {
                IsSuccess = true;
                Value = value;
            }

            private Result(string errorMessage) // failure
            {
                IsSuccess = false;
                ErrorMessage = errorMessage;
            }

            public static Result<T> Success(T value)
            {
                return new Result<T>(value);
            }

            public static Result<T> Failure(string errorMessage)
            {
                return new Result<T>(errorMessage);
            }
        }
    }
}
