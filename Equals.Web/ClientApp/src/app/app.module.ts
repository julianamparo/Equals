import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ArquivoComponent } from './arquivo/arquivo.component';
import { ArquivoServico } from './servicos/arquivos/arquivo.servico'
import { ListaArquivoComponent } from './arquivo/lista/lista.arquivo.component';
 
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ArquivoComponent,
    ListaArquivoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'arquivo', component: ArquivoComponent },
      { path: 'lista-arquivos', component: ListaArquivoComponent }
    ])
  ],
  providers: [ArquivoServico],
  bootstrap: [AppComponent]
})
export class AppModule { }
