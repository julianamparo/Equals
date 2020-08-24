import { Component, OnInit } from "@angular/core";
import { templateJitUrl } from "@angular/compiler";
import { Arquivo } from "../../modelo/arquivo";
import { ArquivoServico } from "../../servicos/arquivos/arquivo.servico";

@Component({
  selector: "lista-arquivo",
  templateUrl: "./lista.arquivo.component.ts",
  styleUrls: ["./lista.arquivo.component.css"] 
})

export class ListaArquivoComponent implements OnInit {

  public arquivos: Arquivo[];
  ngOnInit(): void {
  }

  constructor(private arquivoServico: ArquivoServico) {
    this.arquivoServico.obterArquivos()
      .subscribe(
        arquivos => { this.arquivos = arquivos },
        e => {
          console.log(e.error);
        }     
}
