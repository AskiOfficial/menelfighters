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
        title="Władymir Gomułka"
        subtitle="Prezes wielkiej korporacji w Hrubieszowie"
      >
        Władymir Gomułka, urodzony w Mirosławcu, Ekonomista, Narodowiec i prezes wielkiej korporacji w Hrubieszowie. Szef Jackowskiego, którego szczerze nienawidził. Za młodu dorastał w środowisku Nacjonalistycznym, był harcerzem (tak, je szyszki). Obrzydliwie bogaty człowiek, który wykorzystywał pracowników, przekupywał sądy, żeby nie musieć wypłacać odszkodowań za warunki pracy.
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