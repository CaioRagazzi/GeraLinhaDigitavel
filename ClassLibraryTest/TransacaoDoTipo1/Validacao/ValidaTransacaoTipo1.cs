using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquivoRemessa.TransacaoDoTipo1.Validacao
{
    public class ValidaTransacaoTipo1 : AbstractValidator<TransacaoTipo1>
    {
        public ValidaTransacaoTipo1()
        {
            RuleFor(x => x.DebitoAutomatico)
                .NotNull().WithMessage("É necessário informar o campo DebitoAutomatico");

            RuleFor(x => x.BeneficiariaBanco)
                .NotNull().WithMessage("É necessário ter um objeto do tipo EmpreBeneficiariaBanco");

            RuleFor(x => x.CodigoBancoDebito)
                .NotNull().WithMessage("É necessário ter um CodigoBancoDebito");

            RuleFor(x => x.multa)
                .NotNull().WithMessage("É necessário informar o campo multa");

            RuleFor(x => x.PercentualMulta)
                .NotNull().WithMessage("É necessário informar o campo PercentualMulta");

            RuleFor(x => x.IdentificacaoTituloBanco)
                .NotNull().WithMessage("É necessário informar o campo IdentificacaoTituloBanco");

            RuleFor(x => x.DescontoBonificacaoDia)
                .NotNull().WithMessage("É necessário informar o campo DescontoBonificacaoDia");

            RuleFor(x => x.condicaoEmissaoBoletoCobranca)
                .NotNull().WithMessage("É necessário informar o campo condicaoEmissaoBoletoCobranca");

            RuleFor(x => x.CondicaoRegistroDebitoAutomatico)
                .NotNull().WithMessage("É necessário informar o campo CondicaoRegistroDebitoAutomatico");

            RuleFor(x => x.IndicadorRateioCredito)
                .NotNull().WithMessage("É necessário informar o campo IndicadorRateioCredito");

            RuleFor(x => x.EnderecamentoAvisoDebitoAutomatico)
                .NotNull().WithMessage("É necessário informar o campo EnderecamentoAvisoDebitoAutomatico");

            RuleFor(x => x.PagamentoParcial)
                .NotNull().WithMessage("É necessário informar o campo PagamentoParcial");

            RuleFor(x => x.identificacaoOcorrencia)
                .NotNull().WithMessage("É necessário informar o campo identificacaoOcorrencia");

            RuleFor(x => x.NumeroDocumento)
                .NotNull().WithMessage("É necessário informar o campo NumeroDocumento");

            RuleFor(x => x.DataVencimentoTitulo)
                .NotNull().WithMessage("É necessário informar o campo DataVencimentoTitulo");

            RuleFor(x => x.ValorTitulo)
                .NotNull().WithMessage("É necessário informar o campo ValorTitulo");

            RuleFor(x => x.BancoEncarregadoCobranca)
                .NotNull().WithMessage("É necessário informar o campo BancoEncarregadoCobranca");

            RuleFor(x => x.AgenciaDepositaria)
                .NotNull().WithMessage("É necessário informar o campo AgenciaDepositaria");

            RuleFor(x => x.especieTitulo)
                .NotNull().WithMessage("É necessário informar o campo especieTitulo");

            RuleFor(x => x.DataEmissaoTitulo)
                .NotNull().WithMessage("É necessário informar o campo DataEmissaoTitulo");

            RuleFor(x => x.primeiraInstrucao)
                .NotNull().WithMessage("É necessário informar o campo primeiraInstrucao");

            RuleFor(x => x.SegundaInstrucao)
                .NotNull().WithMessage("É necessário informar o campo SegundaInstrucao");

            RuleFor(x => x.ValorCobrarDiaAtraso)
                .NotNull().WithMessage("É necessário informar o campo ValorCobrarDiaAtraso");

            RuleFor(x => x.DataLimiteConcessaoDesconto)
                .NotNull().WithMessage("É necessário informar o campo DataLimiteConcessaoDesconto");

            RuleFor(x => x.ValorDesconto)
                .NotNull().WithMessage("É necessário informar o campo ValorDesconto");

            RuleFor(x => x.ValorIOF)
                .NotNull().WithMessage("É necessário informar o campo ValorIOF");

            RuleFor(x => x.ValorAbatimento)
                .NotNull().WithMessage("É necessário informar o campo ValorAbatimento");

            RuleFor(x => x.identificacaoTipoInscricao)
                .NotNull().WithMessage("É necessário informar o campo identificacaoTipoInscricao");

            RuleFor(x => x.NumeroInscricaoPagador)
                .NotNull().WithMessage("É necessário informar o campo NumeroInscricaoPagador");

            RuleFor(x => x.NomePagador)
                .NotNull().WithMessage("É necessário informar o campo NomePagador");

            RuleFor(x => x.EnderecoCompleto)
                .NotNull().WithMessage("É necessário informar o campo EnderecoCompleto");

            RuleFor(x => x.PrimeiraMensagem)
                .NotNull().WithMessage("É necessário informar o campo PrimeiraMensagem");

            RuleFor(x => x.Cep)
                .NotNull().WithMessage("É necessário informar o campo Cep");
        }
    }
}
