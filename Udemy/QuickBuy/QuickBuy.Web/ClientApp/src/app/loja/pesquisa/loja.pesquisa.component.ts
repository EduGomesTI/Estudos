import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Produto } from 'src/app/modelo/produto';
import { ProdutoServico } from 'src/app/servicos/produto/produto.servico';

@Component({
  selector: 'app-loja',
  templateUrl: './loja.pesquisa.component.html',
  styleUrls: ['./loja.pesquisa.component.css']
})
export class LojaPesquisaComponentComponent implements OnInit {

  public produtos: Produto[];

  constructor(private produtoServico: ProdutoServico, private router: Router) {

    this.produtoServico.obterTodosProdutos().subscribe(
      produtos =>{
        this.produtos = produtos;
      },
      e => {

      }
    )
   }

  ngOnInit() {
  }

  public abrirProduto(produto: Produto){
    sessionStorage.setItem('produtoDetalhe', JSON.stringify(produto));
    this.router.navigate(['/app-loja.produto']);
  }

}
