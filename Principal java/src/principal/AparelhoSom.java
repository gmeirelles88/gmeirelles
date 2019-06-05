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
public class AparelhoSom extends SomImagem {
    private String marca;
    

    public AparelhoSom(String marca, int potenciaSom, int voltagem) {
        super(potenciaSom, voltagem);
        this.marca = marca;
        this.getPotenciaSom();
        this.getVoltagem();
    }

    AparelhoSom() {
        this("",0,0);
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }
    
    public String mudarEstacao(){
        return(getMarca());
    }        
    
}

