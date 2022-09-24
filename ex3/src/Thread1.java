public class Thread1 extends Thread{
    int mtaken;
    int count;
    String name;


    Thread1(int x, String name){
        mtaken = x;
        this.name = name;
    }
    public void run(){
        synchronized (main.monitor){while(main.money>=mtaken) {
            main.money = main.money - mtaken;
            System.out.println(name + " took " + mtaken + " out of the bank account. Remained " + main.money + " dollars.");
            count++;
            try {
                sleep(1000);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
        }

        }
    }
