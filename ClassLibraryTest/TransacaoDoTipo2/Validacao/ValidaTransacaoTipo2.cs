using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa.TransacaoDoTipo2.Validacao
{
    public class ValidaTransacaoTipo2 : AbstractValidator<TransacaoTipo2>
    {
        public ValidaTransacaoTipo2()
        {
            RuleFor(x => x.Mensagem1)
                .NotNull().WithMessage("É necessário informar o campo Mensagem1");

            RuleFor(x => x.Mensagem2)
                .NotNull().WithMessage("É necessário informar o campo Mensagem2");

            RuleFor(x => x.Mensagem3)
                .NotNull().WithMessage("É necessário informar o campo Mensagem3");

            RuleFor(x => x.Mensagem4)
                .NotNull().WithMessage("É necessário informar o campo Mensagem4");

            RuleFor(x => x.DataLimiteDesconto2)
                .NotNull().WithMessage("É necessário informar o campo DataLimiteDesconto2");

            RuleFor(x => x.ValorDesconto2)
                .NotNull().WithMessage("É necessário informar o campo ValorDesconto2");

            RuleFor(x => x.DataLimiteDesconto3)
                .NotNull().WithMessage("É necessário informar o campo DebitoAutomatiDataLimiteDesconto3co");

            RuleFor(x => x.ValorDesconto3)
                .NotNull().WithMessage("É necessário informar o campo ValorDesconto3");

            RuleFor(x => x.BeneficiariaBanco)
                .NotNull().WithMessage("É necessário informar o campo BeneficiariaBanco");

            RuleFor(x => x.NossoNumero)
                .NotNull().WithMessage("É necessário informar o campo NossoNumero");

        }
    }
}
