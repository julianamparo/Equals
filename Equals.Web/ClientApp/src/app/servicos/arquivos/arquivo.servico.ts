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

  public carregar(arquivo: Arquivo): Observable<Arquivo> {

    return this.http.post<Arquivo>(this._baseUrl + "api/arquivo/carregar", JSON.stringify(arquivo), { headers: this.headers });
  }

  public arquivoUpload(arquivoSelecionado: File): Observable<boolean> {
    const formData: FormData = new FormData();
    formData.append("arquivoCarregado", arquivoSelecionado, arquivoSelecionado.name);
    return this.http.post<boolean>(this._baseUrl + "api/arquivo/arquivoUpload", formData);

  }

  public obterArquivos(): Observable<Arquivo[]> {
    return this.http.get<Arquivo[]>(this._baseUrl + "api/arquivo");
  }

  //public obterArquivo(arquivoId: number): Observable<Arquivo> {
  //  return this.http.get<Arquivo>(this._baseUrl + "api/arquivo/obter");
  //}


}
