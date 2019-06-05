/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package principal;

/**
 *
 * @author Gabriel
 */
public class LinhaBranca extends Eletroeletronico {
    
    private String classificacaoConsumo;

    public LinhaBranca(String classificacaoConsumo, int voltagem) {
        super(voltagem);
        this.classificacaoConsumo = classificacaoConsumo;
    }

    public String getClassificacaoConsumo() {
        return classificacaoConsumo;
    }

    public void setClassificacaoConsumo(String classificacaoConsumo) {
        this.classificacaoConsumo = classificacaoConsumo;
    }
    
    public String abrir(){
        return("" + this.getClassificacaoConsumo());
    }
    public String fechar(){
        return("");
    }
   
    
    
    
}
