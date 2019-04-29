using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa
{
    public class ValidaHeader : AbstractValidator<Header>
    {
        public ValidaHeader()
        {
            RuleFor(x => x.CodEmpresa)
                .NotNull().WithMessage("É necessário informar o campo CodEmpresa");

            RuleFor(x => x.NomeEmpresa)
                .NotNull().WithMessage("É necessário informar o campo NomeEmpresa");

            RuleFor(x => x.NumeroBradesco)
                .NotNull().WithMessage("É necessário informar o campo NumeroBradesco");

            RuleFor(x => x.NomeBanco)
                .NotNull().WithMessage("É necessário informar o campo NomeBanco");

            RuleFor(x => x.DataGravacaoArquivo)
                .NotNull().WithMessage("É necessário informar o campo DataGravacaoArquivo");

            RuleFor(x => x.IdentSistema)
                .NotNull().WithMessage("É necessário informar o campo IdentSistema");

            RuleFor(x => x.NumSeqRemessa)
                .NotNull().WithMessage("É necessário informar o campo NumSeqRemessa");

        }
    }
}
