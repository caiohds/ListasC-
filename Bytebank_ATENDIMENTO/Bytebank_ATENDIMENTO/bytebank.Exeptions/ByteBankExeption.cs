using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Exeptions
{

	[Serializable]
	public class ByteBankExeption : Exception
	{
		public MyException() { }
		public MyException(string message) : base(message) { }
		public MyException(string message, Exception inner) : base(message, inner) { }
		protected MyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
