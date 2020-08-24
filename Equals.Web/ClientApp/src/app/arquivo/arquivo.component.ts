import { Component, OnInit } from "@angular/core"
import { Arquivo } from "../modelo/arquivo";
import { ArquivoServico } from "../servicos/arquivos/arquivo.servico";

@Component({
  selector: "app-arquivo",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]

})
export class ArquivoComponent implements OnInit {

  public arquivo: Arquivo

  constructor(private arquivoServico: ArquivoServico) {

  }

  ngOnInit(): void {
    this.arquivo = new Arquivo();
  }

  public cadastrar() {
    this.arquivoServico.cadastrar(this.arquivo)
      .subscribe(
        produtoJson => {
          console.log(produtoJson)

        },
        e => {
          console.log(e.error);
        }
      );
  }

}


