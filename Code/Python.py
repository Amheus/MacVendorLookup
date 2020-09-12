import requests

macAddress = input("mac: ")

vendor = requests.get('http://api.macvendors.com/' + macAddress).text
print(macAddress + " --> " + vendor)
