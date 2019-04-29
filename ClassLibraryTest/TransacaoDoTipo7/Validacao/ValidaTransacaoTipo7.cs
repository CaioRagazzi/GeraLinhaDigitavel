using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa.TransacaoDoTipo7.Validacao
{
    public class ValidaTransacaoTipo7 : AbstractValidator<TransacaoTipo7>
    {
        public ValidaTransacaoTipo7()
        {
            RuleFor(x => x.EnderecoSacadorAvalista)
                .NotNull().WithMessage("É necessário informar o campo EnderecoSacadorAvalista");

            RuleFor(x => x.Cep)
                .NotNull().WithMessage("É necessário informar o campo Cep");

            RuleFor(x => x.SufixoCep)
                .NotNull().WithMessage("É necessário informar o campo SufixoCep");

            RuleFor(x => x.Cidade)
                .NotNull().WithMessage("É necessário informar o campo Cidade");

            RuleFor(x => x.Uf)
                .NotNull().WithMessage("É necessário informar o campo Uf");

            RuleFor(x => x.empresaBeneficiariaBanco)
                .NotNull().WithMessage("É necessário informar o campo empresaBeneficiariaBanco");

            RuleFor(x => x.NossoNumero)
                .NotNull().WithMessage("É necessário informar o campo NossoNumero");

            RuleFor(x => x.DacNossoNumero)
                .NotNull().WithMessage("É necessário informar o campo DacNossoNumero");
        }        
    }
}
