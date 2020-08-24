import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Http } from "@angular/http";
import { Arquivo } from "../../modelo/arquivo";


@Injectable({
  providedIn: 'root'
})
export class ArquivoServico implements OnInit{

  private _baseUrl: string;
  public files: Arquivo[];

  constructor(private http: HttpClient, @Inject('BASE URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.files = [];
  }
  

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public cadastrar(arquivo: Arquivo): Observable<Arquivo> {
    const headers = new HttpHeaders().set('content-type', 'application/json')

    var body = {
      nome: arquivo.nomearquivo,
      recepcionado: arquivo.recepcionado,
      datarecepcao: arquivo.datarecepcao
    }
    return this.http.post<Arquivo>(this, this._baseUrl + "api/arquivo/salvar", JSON.stringify(arquivo), { headers: this.headers })
  }

  public obterArquivos(): Observable<Arquivo[]> {
    return this.http.get<Arquivo[]>(this._baseUrl + "api/arquivo");
  }

  public obterArquivo(arquivoId: number): Observable<Arquivo> {
    return this.http.get<Arquivo>(this._baseUrl + "api/arquivo/obter");
  }


}
