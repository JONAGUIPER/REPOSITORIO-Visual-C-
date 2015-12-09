<div class="post-date radius-100 updated">
<span>
<a href="<?php the_permalink(); ?>">
<?php echo get_the_date( 'd' ) ?></span><br /><?php echo get_the_date( 'M' ) ?><br /><?php echo get_the_date( 'Y' ) ?></a></div>
      <h2 class="post-title entry-title" itemprop="headline"><a href="<?php the_permalink(); ?>" rel="<?php esc_attr_e( 'bookmark', 'adelle-theme' ); ?>"><?php the_title(); ?></a></h2>
      <div class="post-category"><?php _e( 'categories', 'adelle-theme' ); ?>: <?php the_category( ', ' ); ?></div>
    </header>

    <?php if ( has_post_thumbnail() ) { the_post_thumbnail( 'post_thumb', array( 'class'=>'alignleft' ) ); } ?>
      
      <article class="post-content" itemprop="text">

        <?php the_content(); ?>