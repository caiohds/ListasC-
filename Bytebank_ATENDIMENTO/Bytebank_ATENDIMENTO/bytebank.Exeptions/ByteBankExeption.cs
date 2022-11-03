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
		public ByteBankExeption() { }
		public ByteBankExeption(string message) : base("Aconteceu uma exceção -> " + message) { }
		public ByteBankExeption(string message, Exception inner) : base(message, inner) { }
		protected ByteBankExeption(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
