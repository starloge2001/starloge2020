import time

start = time.time()
print('start',start)

while True:
    time.sleep(1)
    end = time.time()
    print('end',end)
    if(end - start) > 3 :
        print ("3초지남")
        break