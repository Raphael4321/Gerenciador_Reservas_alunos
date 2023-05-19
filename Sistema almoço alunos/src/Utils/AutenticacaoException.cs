using System;
using System.Runtime.Serialization;

namespace Sistema_almoço_alunos.src.Repository
{
    [Serializable]
    internal class AutenticacaoException : Exception
    {
        public AutenticacaoException()
        {
        }

        public AutenticacaoException(string message) : base(message)
        {
        }

        public AutenticacaoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AutenticacaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}