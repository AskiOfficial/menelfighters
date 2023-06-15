<template>
    <h1 class="text-center"><v-icon icon="mdi-help"></v-icon>O Postaciach</h1>


  <v-card color="#dc9b59" class="pa-2 ma-16" title="Mariusz Jackowski" subtitle="Protagonista">
    <v-card-actions>
      <router-link to="/about/mariusz"><v-btn>Poznaj</v-btn></router-link>
    </v-card-actions>
  </v-card> <!-- tu jest główna postać i ona dostanie większego vcarda ok ok ? -->

  <v-divider :thickness="5"></v-divider>

  <v-container class="bg-surface-variant pt-5">
    <v-row no-gutters>
      <v-col order="6">
        <v-card color="#d8a064" class="pa-2 ma-2" title="Romuald Apetrei" subtitle="Włóczykij">
          <v-card-actions>
            <v-btn>Poznaj</v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col order="12">
        <v-card color="#d8a064" class="pa-2 ma-2" title="Władymir Gomułka" subtitle="Prezes wielkiej korporacji w Hrubieszowie">
          <v-card-actions>
            <v-btn>Poznaj</v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col order="1">
        <v-card color="#d8a064" class="pa-2 ma-2" title="Pani Halinka" subtitle="Worochta przy granicy Rumuńskiej">
          <v-card-actions>
            <v-btn>Poznaj</v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<style>
h1{
  color: #39FF14;
}


</style>