<template>
  <span class="bg"></span>
  <v-container class="backgroundImage">
    <h1 class="pa-5 text-center fixH2">
      <v-icon icon="mdi-download" />Pobieranie
    </h1>


    <h2 class="text-center pt-12 fixH2 gameName">
      Menel Fighters 1.0.0
    </h2>
    <a
      href="https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley"
      target="_blank"
    >
      <v-img
        src="https://cdn.discordapp.com/attachments/1095791512593371148/1118847687987572756/pobieranie.jpg"
        alt="Pobierz"
        width="20%"
        height="15%"
        class="pt-6 mx-auto d-block"
      />
    </a>
  </v-container>
</template>

<script>
export default {
  name: "DownloadView",
  data(){

  }
}
</script>

<style scoped>
h2{
  color: #4B5320;
}
.bg {
  width: 100%;
  height: 100%;
  position: absolute;
  background: url('https://cdn.discordapp.com/attachments/1095791512593371148/1118858290873511946/sciana.jpg');
  background-size: cover;
}
.fixH2{
  position: relative;
}
.gameName{
  font-size: 50px;
  outline-color: white;
  outline-style: solid;
}
</style>