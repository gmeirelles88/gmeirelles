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
public class SomImagem extends Eletroeletronico {
    
    private int potenciaSom;

    public SomImagem(int potenciaSom, int voltagem) {
        super(voltagem);
        this.potenciaSom = potenciaSom;
    }

    public int getPotenciaSom() {
        return potenciaSom;
    }

    public void setPotenciaSom(int potenciaSom) {
        this.potenciaSom = potenciaSom;
        
    }
    
    public String entrarStandby(){
        return ("");
    }
    public String sairStandby(){
        return("");
    }
}
