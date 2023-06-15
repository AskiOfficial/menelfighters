<template>
  <h1 class="text-center">
    <v-icon icon="mdi-help" />O Postaciach
  </h1>

  <v-container>
    <v-row>
      <v-card
        color="#dc9b59"
        width="50%"
        class="pa-3 ma-10 bigText"
        title="Mariusz Jackowski"
        subtitle="Protagonista"
      >
        <p>Data urodzenia 20.05.1977.</p>
        Świeżo upieczony menel, koneser wielorakich trunków (oczywiście alkoholizujących),
        były pracownik gigantycznej korporacji wylądował na ulicach przez rozwód ze swoją podłą żoną.
        <p>Zdesperowany za wszelką cenę odegra się na żonie, współpracownikach i byłym szefie. Chcąc przejąć super korporacje,</p>
        w której pracował.<br> Od zbieracza szrapneli po znakomitego boksera walk podziemnych i właściciela ogólnoświatowej korporacji.</v-card>
      <v-img
        height="19%"
        width="30%"
        src="https://cdn.discordapp.com/attachments/1095791512593371148/1118632756335870062/prota.png"
      />
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: "MariuszView"
}
</script>

<style scoped>
.bigText{
  font-size: 30px;
}
</style>