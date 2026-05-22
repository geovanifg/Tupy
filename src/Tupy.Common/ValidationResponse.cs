//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace Consumer.CommonObjects.Responses
//{

//    public interface IValidationResponse
//    {
//        IEnumerable<ValidationResult> Validations { get; set; }
//    }

//    public class ValidationResponse<T> : SingleResponse<T>, IValidationResponse
//    {
//        public IEnumerable<ValidationResult> Validations { get; set; }

//        public ValidationResponse() : base()
//        {

//        }

//        public ValidationResponse(bool success, string message) : base(success, message)
//        {
//        }

//        public ValidationResponse(bool success) : base(success, "")
//        {
//        }

//        public ValidationResponse(string errorMessage) : base(false, errorMessage)
//        {
//        }
//    }
//}
