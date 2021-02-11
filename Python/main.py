from funcoes.func import pscan

host = input("Enter the ip adress: ")
port = int(input("Enter the last port Number: "))

for p in range(1, port):
    pscan(host, p)





