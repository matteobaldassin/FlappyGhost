/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flappy;

/**
 *
 * @author Zeta
 */
public class CPunto {
    private int x,y;
    
    public CPunto(){x=0;y=0;};
    public CPunto(int x,int y){x=0;y=0;};
    
    public int getX(){ return x;}
    public int getY(){ return y;}
    
    public void setX(int newX){x=newX;};
    public void setY(int newy){y=newy;};
    
}
