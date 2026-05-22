//using System;

//namespace Consumer.CommonObjects.Responses
//{
//    public class ResponseExtensions
//    {
//        public static T CreateSucess<T>() where T : IExecutionResponse, new()
//        {
//            return new T() { Success = true };
//        }

//        public static T CreateSucess<T>(string message) where T : IExecutionResponse, new()
//        {
//            return new T()
//            {
//                Success = true,
//                Message = message
//            };
//        }

//        public static T CreateFailure<T>(string message) where T : IExecutionResponse, new()
//        {
//            return new T()
//            {
//                Success = false,
//                Message = message
//            };
//        }

//        public static T CreateFailure<T>(string message, Exception ex) where T : IExecutionResponse, new()
//        {
//            return new T()
//            {
//                Success = false,
//                Message = message,
//                Exception = ex,
//            };
//        }

//        public static T CreateFailure<T>(Exception ex) where T : IExecutionResponse, new()
//        {
//            return new T()
//            {
//                Success = false,
//                Message = ex.Message,
//                Exception = ex,
//            };
//        }
//    }
//}
