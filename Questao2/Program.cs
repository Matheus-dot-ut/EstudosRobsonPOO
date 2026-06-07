PagamentoPix pix = new PagamentoPix();
pix.ReceberDadosPix();
pix.ProcessarPagamento();
pix.MostrarPagamento();

PagamentoCartaoCredito cartao = new PagamentoCartaoCredito();
cartao.ReceberDadosCartao();
cartao.ProcessarPagamento();
cartao.MostrarPagamento();