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
        title="Pani Halinka"
        subtitle="Worochta przy granicy Rumuńskiej"
      >
        Kobieta o poglądach komunistycznych. Córka czerwonego działacza „Wojtka” Karuzelskiego. Ambitna chciała wyemigrować do ZSRR, nim się rozpadło, ale skończyła w małym sklepie w Hrubieszowie. Ma męża alkoholika, który jest bezrobotny i przepija cały dochód ze sklepu. Diler w kamienicach Brajan to jej syn.
      </v-card>
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