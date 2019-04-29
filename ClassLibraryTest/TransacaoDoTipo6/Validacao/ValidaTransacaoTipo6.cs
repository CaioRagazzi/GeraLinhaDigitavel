using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa.TransacaoDoTipo6.Validacao
{
    public class ValidaTransacaoTipo6 : AbstractValidator<TransacaoTipo6>
    {
        public ValidaTransacaoTipo6()
        {
            RuleFor(x => x.empresaBeneficiariaBanco)
                .NotNull().WithMessage("É necessário informar o campo empresaBeneficiariaBanco");

            RuleFor(x => x.NossoNumero)
                .NotNull().WithMessage("É necessário informar o campo NossoNumero");

        }
    }
}
