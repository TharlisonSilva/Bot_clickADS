from tbselenium.tbdriver import TorBrowserDriver
#from selenium import webdriver 
import time
import random
while True:
    try:
        with TorBrowserDriver("/home/talles/Documentos/ClickPay_linux/tor-browser_en-US/") as driver:
        #driver = webdriver.Firefox()     
            links = ['http://raboninco.com/21QL8','http://raboninco.com/20YIv',
                     'http://raboninco.com/21QNB','http://raboninco.com/20YGS',
                     'http://raboninco.com/21QOE','http://raboninco.com/20YEK',
                     'http://raboninco.com/21QRR','http://raboninco.com/21QSn',
                     'http://raboninco.com/21QTa','http://raboninco.com/21QUF',
                     'http://raboninco.com/21QVR']
            sorteio = random.randint(0, 10)
            driver.get(links[sorteio])
            time.sleep(14)    
            busca = driver.find_element_by_id('skip_bu2tton')
            
            busca.click()
            time.sleep(3)
            driver

    except NameError:
        sorteio = 0