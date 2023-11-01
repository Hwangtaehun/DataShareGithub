(define (domain redridinghood)
(:requirements :strips :negative-preconditions :equality)
(:predicates (at ?p ?loc)    ; ?p is at ?loc
             (happy ?p)
             (have ?p ?obj)) ; ?p has ?obj 

(:action moveto
  :parameters (?p ?from ?to)
  :precondition (and (at ?p ?from))
  :effect (and (at ?p ?to) (not (at ?p ?from))))
  
(:action greet
  :parameters (?p1 ?p2 ?loc)
  :precondition (and (at ?p1 ?loc) (at ?p2 ?loc) (not (= ?p1 ?p2)))
  :effect (and (happy ?p1) (happy ?p2)))
 
(:action give
  :parameters (?p1 ?p2 ?obj ?loc)
  :precondition (and (have ?p1 ?obj) (at ?p1 ?loc) (at ?p2 ?loc))
  :effect (and (at ?p2 ?obj) 
               (not (have ?p1 ?obj)))))