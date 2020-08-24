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
  public arquivoSelecionado: File

  constructor(private arquivoServico: ArquivoServico) {

  }

  ngOnInit(): void {
    this.arquivo = new Arquivo();
  }

  public arquivoUpload(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    alert(this.arquivoSelecionado.name);
    this.arquivoServico.arquivoUpload(this.arquivoSelecionado)
      .subscribe(
        retorno => {
          console.log(retorno);
        },
        e => {
          console.log(e.error);
        });
  }

  public carregar() {
    this.arquivoServico.carregar(this.arquivo)
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


