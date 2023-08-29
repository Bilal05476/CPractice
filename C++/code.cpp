// Online C++ compiler to run C++ program online
#include <iostream>
#include <string>
using namespace std;

void exm(string name = "Ahmed", int age = 0){
    cout << "Hello " << name << ", your age is: " << age << "\n";
}

int sum(int x, int y){
    return x + y;
}
double sum(double x, double y){
    return x + y;
}

void printArr(int arr[6]){
    for(int i = 0; i < 6; i++){
        cout << arr[i] << "\n";
    }
}

int recur(int k) {
  if (k > 0) {
    cout << k << "\n";
    return k + recur(k - 1);
  } else {
    return 0;
  }
}

class Vehicle{
    public:
    void honk(){
        cout << "Tuut, Tuut! \n";
    }
};

class Car : public Vehicle {
    string brand;
    public:
    string name;
    int year;
    string model;
    //constructor
    Car(int x, string y, string z){
        year = x;
        name = y;
        model = z;
        
    }
    // method / function
    int maxSpeed(int x){
        return x;
    }
    
    // encapsulation (get, set for private brand)
    void setBrand(string x){
        brand = x;
    }
    string getBrand(){
        return brand;
    }
};

// polymorphism (different class but same in many ways)
class Animal{
  public:
  void sound(){
      cout << "Animal Sound \n";
  }
};

class Pig : public Animal {
    public:
    void sound(){
        cout << "Pig Sound \n";
    }
};

int main() {
    // Write C++ code here
    Car car(2023, "Civic", "xli");
    car.setBrand("Honda");
    car.honk();
    Pig pig;
    pig.sound();
    
    cout << car.name << "\n" << car.model << "\n" << car.year << "\n" << car.maxSpeed(200) << "\n" << car.getBrand();
    // cout << recur(10);
    // exm("Bilal", 23);
    // exm("smith", 22);
    // exm();
    // cout << sum(2.3,3.9);
    // int arr[6] = {23,22,21,20,19,18};
    // printArr(arr);
    return 0;
}