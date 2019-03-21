namespace GameManager
{
    internal class ValidationContext
    {
        private IValidatableObject value;

        public ValidationContext( IValidatableObject value )
        {
            this.value = value;
        }
    }
}