public class javademo{

public static void main(String args[]){

System.out.println("1000以内的完全数:");

for(int i=1;i<1000;i++){

int t=0;

for(int j=1;j<=i/2;j++){if(i%j==0)t=t+j;}

if(i==t)

System.out.print(i+" ");

}

}

}