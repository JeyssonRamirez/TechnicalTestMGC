//   -----------------------------------------------------------------------
//   <copyright file=ResponseApi.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 9:07 PM</Date>
//   <Update> 2019-01-04 - 9:54 PM</Update>
//   -----------------------------------------------------------------------

namespace Core.DataTransferObject
{
    public class ResponseApi
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int ResponseCode { get; set; }
        public object Data { get; set; }
    }
}