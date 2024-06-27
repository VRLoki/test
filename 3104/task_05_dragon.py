class SwimMixin:
    def swim(self):
        print("The creature swims!")

class FlyMixin:
    def fly(self):
        print("The creature flies!")

# Dragon class implementing both mixins
class Dragon(SwimMixin, FlyMixin):
    def roar(self):
        print("The dragon roars!")
