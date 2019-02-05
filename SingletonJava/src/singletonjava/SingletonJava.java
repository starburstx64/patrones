
package singletonjava;

/**
 *
 * @author starb
 */
public class SingletonJava {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        SingletonObject singletonObject = SingletonObject.getInstance();
        singletonObject.doSomething();
        
        SingletonObject.getInstance().doSomething();
    }
    
}
