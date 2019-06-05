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
public class Geladeira extends LinhaBranca {
    
    private String cor;

    public Geladeira(){
       this("","",0);
    }
    public Geladeira(String cor, String classificacaoConsumo, int voltagem) {
        super(classificacaoConsumo, voltagem);
        this.cor = getCor();
        this.getClassificacaoConsumo();
        this.getVoltagem();
    }

    
      
    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }
    
    public String descongelar(){
        return ("A geladeira " + getCor()+ " está descongelando");
    }
}
