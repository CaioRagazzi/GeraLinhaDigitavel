using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa.TransacaoDoTipo3.Validacao
{
    public class ValidaTransacaoTipo3 : AbstractValidator<TransacaoTipo3>
    {
        public ValidaTransacaoTipo3()
        {
            RuleFor(x => x.IdentificacaoTituloBanco)
                .NotNull().WithMessage("É necessário informar o campo IdentificacaoTituloBanco");

            RuleFor(x => x.codigoCalculoRateio)
                .NotNull().WithMessage("É necessário informar o campo codigoCalculoRateio");

            RuleFor(x => x.tipoValorInformado)
                .NotNull().WithMessage("É necessário informar o campo tipoValorInformado");

            RuleFor(x => x.CodigoAgenciaCreditoPrimeiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo CodigoAgenciaCreditoPrimeiroBeneficiario");

            RuleFor(x => x.DigitoAgenciaCreditoPrimeiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo DigitoAgenciaCreditoPrimeiroBeneficiario");

            RuleFor(x => x.NumeroContaCorrenteCreditoPrimeiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo NumeroContaCorrenteCreditoPrimeiroBeneficiario");

            RuleFor(x => x.DigitoContaCorrenteCreditoPrimeiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo DigitoContaCorrenteCreditoPrimeiroBeneficiario");

            RuleFor(x => x.Filler2)
                .NotNull().WithMessage("É necessário informar o campo Filler2");

            RuleFor(x => x.Parcela)
                .NotNull().WithMessage("É necessário informar o campo Parcela");

            RuleFor(x => x.CodigoBancoCreditoSegundoBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo CodigoBancoCreditoSegundoBeneficiario");

            RuleFor(x => x.CodigoAgenciaCreditoSegundoBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo CodigoAgenciaCreditoSegundoBeneficiario");

            RuleFor(x => x.DigitoAgenciaCreditoSegundoBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo DigitoAgenciaCreditoSegundoBeneficiario");

            RuleFor(x => x.NumeroContaCorrenteCreditoSegundoBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo NumeroContaCorrenteCreditoSegundoBeneficiario");

            RuleFor(x => x.DigitoContaCorrenteCreditoSegundoBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo DigitoContaCorrenteCreditoSegundoBeneficiario");

            RuleFor(x => x.Filler3)
                .NotNull().WithMessage("É necessário informar o campo Filler3");

            RuleFor(x => x.Parcela2)
                .NotNull().WithMessage("É necessário informar o campo Parcela2");

            RuleFor(x => x.FloatingSegundoBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo FloatingSegundoBeneficiario");

            RuleFor(x => x.CodigoBancoCreditoTerceiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo CodigoBancoCreditoTerceiroBeneficiario");

            RuleFor(x => x.CodigoAgenciaCreditoTerceiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo CodigoAgenciaCreditoTerceiroBeneficiario");

            RuleFor(x => x.DigitoAgenciaCreditoTerceiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo DigitoAgenciaCreditoTerceiroBeneficiario");

            RuleFor(x => x.NumeroContaCorrenteCreditoTerceiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo NumeroContaCorrenteCreditoTerceiroBeneficiario");

            RuleFor(x => x.DigitoContaCorrenteCreditoTerceiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo DigitoContaCorrenteCreditoTerceiroBeneficiario");

            RuleFor(x => x.ValorOuParcelamentoRateio3)
                .NotNull().WithMessage("É necessário informar o campo ValorOuParcelamentoRateio3");

            RuleFor(x => x.Filler4)
                .NotNull().WithMessage("É necessário informar o campo Filler4");

            RuleFor(x => x.Parcela3)
                .NotNull().WithMessage("É necessário informar o campo Parcela3");

            RuleFor(x => x.FloatingTerceiroBeneficiario)
                .NotNull().WithMessage("É necessário informar o campo FloatingTerceiroBeneficiario");

        }
    }
}
