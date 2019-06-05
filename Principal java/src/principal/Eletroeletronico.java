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
public class Eletroeletronico {
    private int voltagem;

    public Eletroeletronico(int voltagem) {
        this.voltagem = voltagem;
        
    }

    public int getVoltagem() {
        return voltagem;
    }

    public void setVoltagem(int voltagem) {
        this.voltagem = voltagem;
    }
    
    public String ligar (){
        return ("Esse aparelho doméstico liga com a voltagem de " + this.getVoltagem()+ "V");        
    }
}
