import { Component } from '@angular/core';

@Component({
    selector: 'produto',
    templateUrl: './produto.component.html',
    styleUrls: ['./produto.component.css']
})
/** produto component*/
export class ProdutoComponent {
    /** produto ctor */
    constructor() {}

  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return 'SanSung';
  }
}
