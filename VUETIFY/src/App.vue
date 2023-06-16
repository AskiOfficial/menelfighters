<template>
  <nav>
    <right>
      <router-link to="/">
        <v-icon icon="mdi-home" />Strona Główna
      </router-link> |
      <router-link to="/download">
        <v-icon icon="mdi-download" />Pobieranie
      </router-link> |
      <router-link to="/about">
        <v-icon icon="mdi-help" />O Postaciach
      </router-link>
    </right>
  </nav>
  <router-view />
</template>

<style>
#app {
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #ff10f0;
}

nav a.router-link-exact-active {
  color: #39FF14;
}

right{
  float: right;
}

body{
  background-color: #2c2525;
}

a:link { text-decoration: none; }
a:visited { text-decoration: none; }
a:hover { text-decoration: none; }
a:active { text-decoration: none; }

.inline{
  display: inline;
}
</style>
