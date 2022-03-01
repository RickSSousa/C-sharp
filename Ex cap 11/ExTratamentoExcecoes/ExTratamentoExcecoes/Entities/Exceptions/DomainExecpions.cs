using System;

namespace ExTratamentoExcecoes.Entities.Exceptions
{
    class DomainExecpions : ApplicationException
    {
        public DomainExecpions (string message) : base(message)
        {
        }
    }
}
