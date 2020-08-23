import { Component } from "@angular/core"

@Component({
  selector: "app-arquivo",
  template: "<html><body>{{ getNome() }}</body></html>"

})
  export class ArquivoComponent {
  public nome: string;
  public recepcionado: boolean;
  public dataRecepcao: Date;

  public getNome(): string {
    return this.nome;
  }
}
