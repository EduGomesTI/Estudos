import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Produto } from 'src/app/modelo/produto';
import { ProdutoServico } from 'src/app/servicos/produto/produto.servico';

@Component({
  selector: 'app-loja.produto',
  templateUrl: './loja.produto.component.html',
  styleUrls: ['./loja.produto.component.css']
})
export class LojaProdutoComponent implements OnInit {

  public produto: Produto

  constructor(private produtoServico: ProdutoServico, private router: Router) { }

  ngOnInit() {    
   this.produto = this.getProduto();
  }

  //Retorna o produto que foi clicado pelo usuário no card de produtos da loja
  public getProduto(): Produto{
    var produtoDetalhe = sessionStorage.getItem('produtoDetalhe');
    if (produtoDetalhe){
      return JSON.parse(produtoDetalhe);
    }
  }

  public comprar() {
    this.router.navigate(["/loja-efetivar"]);
  }

}
