from tbselenium.tbdriver import TorBrowserDriver
import time
import random
while True:
    try:
        with TorBrowserDriver("/home/talles/Documentos/ClickPay_linux/tor-browser_en-US/") as driver: 
            links = ['https://youtu.be/fIGOheuyhss',      'https://youtu.be/UxAirOfsAV0',
                     'https://youtu.be/eAVVq5yjYkI',      'https://youtu.be/eAVVq5yjYkI?t=77',
                     'https://youtu.be/UxAirOfsAV0?t=99', 'https://youtu.be/fIGOheuyhss?t=21']
            sorteio = random.randint(0, 6)
            driver.get(links[sorteio])
            
            #driver.get('https://www.youtube.com/watch?v=UxAirOfsAV0&feature=youtu.be')
            time.sleep(random.randint(5, 10))
            driver.find_element_by_tag_name('body').send_keys('k') 
            
            sorteio = random.randint(25, 100)
            time.sleep(sorteio)

            #busca = driver.find_element_by_id('skip_bu2tton')
            #busca.click()
            #time.sleep(3)
    except NameError:
        sorteio = 0