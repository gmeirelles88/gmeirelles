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
public class Televisao extends SomImagem {
    
    private int tamanho;

   
    public Televisao(int tamanho, int potenciaSom, int voltagem) {
        super(potenciaSom, voltagem);
        this.tamanho = tamanho;
        this.getPotenciaSom();
        this.getVoltagem();
    }

    public Televisao() {
        this(0,0,0);
    }

    public int getTamanho() {
        return tamanho;
    }

    public void setTamanho(int tamanho) {
        this.tamanho = tamanho;
    }
    
    public String mudarCanal(){
        return ("A tv de " + getTamanho() + " polegadas " + " liga com voltagem de " +getVoltagem()+ "V");
    }
}
