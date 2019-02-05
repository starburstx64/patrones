
package singletonjava;

/**
 *
 * @author starb
 */
public class SingletonObject {
    
    private static SingletonObject instance = null;
    
    private SingletonObject()
    {
        System.out.println("Llamando al constructor de SingletonObject");
    }
    
    public static SingletonObject getInstance()
    {
        System.out.println("Llamando a getInstance de SingletonObject");
        
        if (instance == null) {
            instance = new SingletonObject();
        }
        
        return instance;
    }
    
    public void doSomething()
    {
        System.out.println("Llamando a doSomething de SingletonObject");
    }
}
