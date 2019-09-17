class CompteBancaire:
    
    def __init__(self, Nom='Duchmol', solde=1000):
        
        self.Nom=Nom
        self.solde=solde
    def depot(self, ajout):
        self.solde = self.solde + ajout
    def retrait(self, retire):
        self.solde = self.solde - retire
    def affiche(self):
        print('Le solde du compte bancaire de %s est de %2.f €'%(self.Nom, self.solde))
        
        
cb=CompteBancaire()
cb.Nom
cb.solde
cb.depot(200) 
cb.affiche()

compte1=CompteBancaire('Mike', 1000000)
compte1.Nom
compte1.solde
compte1.depot(50000)
compte1.retrait(2000) 
compte1.affiche()
    
    
    