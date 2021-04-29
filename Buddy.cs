const int LED_PIN = D7;
const int BLINK = 3;
const int TIME = 200;


const int PAT_BLINK = 5;
const int PAT_TIME = 100;

void myHandler(const char *event, const char *data);
void blink(int led, int blinks, int delayTime);



void setup()
{
    pinMode(LED_PIN, OUTPUT);
    
    Particle.subscribe("wave", myHandler);
    Particle.subscribe("pat", myHandlertwo);
    
}

void loop()
{
    delay(6000);
    Particle.publish("wave", "motion");
    delay(3000);
    Particle.publish("pat", "patmotion");

    
}
    
void myHandler(const char*event, const char*data)
{
    
    blink(LED_PIN, BLINK, TIME);
    

}

void myHandlertwo(const char*event, const char*data)
{
    
    blink(LED_PIN, PAT_BLINK, PAT_TIME);
    
}

void blink(int led, int blinks, int delaytime)
{
    for(int i=0; i < blinks; i++)
    {
        digitalWrite(led, HIGH);
        delay(delaytime);
        digitalWrite(led, LOW);
        delay(delaytime);
    }
}