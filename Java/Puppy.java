public class Puppy{
    int puppyAge;
    public Puppy(String name){
	//这个构造器仅有一个参数：name
	System.out.println("Dog's name :\n" + name );
    }

    public void setAge( int age ){
	puppyAge = age;
    }

    public int getAge(){
	System.out.println("Dog's Age is : " + puppyAge );
	return puppyAge;
    }
    
    public static void main(String []args){
	/* 创建对象 */
	Puppy myPuppy = new Puppy("tommy");
	/* 通过方法设定age */
	myPuppy.setAge( 2 );
	/* 调用另一个方法获取age */
	myPuppy.getAge( );
	/*另一个方法访问成员变量*/
	System.out.println("path : " +myPuppy.puppyAge );
    }
}
